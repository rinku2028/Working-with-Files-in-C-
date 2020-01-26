<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fileuploadindrive.aspx.cs" Inherits="fileupload.fileuploadindrive" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Button ID="btnupload" runat="server" Text="UPLOAD FILE WITH SIZE" />
        </div>
    </form>
</body>
</html>
