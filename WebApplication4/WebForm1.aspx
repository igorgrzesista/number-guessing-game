<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Guess a number (1-100)</div>
        <p>
            <asp:TextBox ID="text" runat="server" OnTextChanged="text_TextChanged" style="height: 22px"></asp:TextBox>
            <asp:Button ID="checkButton" runat="server" Text="Check!" Height="26px" OnClick="checkButton_Click" />
        </p>
        <p>
            <asp:Label ID="serverAnswerLabel" runat="server" Text=""></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
