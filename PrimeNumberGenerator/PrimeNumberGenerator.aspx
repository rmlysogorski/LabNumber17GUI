<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrimeNumberGenerator.aspx.cs" Inherits="PrimeNumberGenerator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="display:inline-block;padding:10px 10px 10px 10px">
            <p>Let's generate some prime numbers!</p>
            Enter a number:&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" TextMode="Number"></asp:TextBox>
            <asp:Button ID="PrimeButton" runat="server" Text="Generate Prime Number!" OnClick="PrimeButton_Click" />
            <br /><br />
            <asp:Label ID="PrimeNumberLabel" runat="server" Text="Label" Visible="False"></asp:Label>
        </div>
    </form>
</body>
</html>
