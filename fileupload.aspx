<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fileupload.aspx.cs" Inherits="fileupload.fileupload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="fileupload1" runat="server" />
            <asp:Button ID="btnupload" runat="server" Text="Upload File" OnClick="btnupload_Click" />
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>
