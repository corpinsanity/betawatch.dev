<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="betawatch._default" %>

<!DOCTYPE html>
<link href="Styles/CrackwatchStyles.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Betawatch</title>
</head>

<body>
    <header>
        <div id="Header">
            <a href="login.aspx"><img id="ProfileIcon" src="Images/profile_ico.png"></a>
            <img id="BetaIcon" src="Images/beta_ico.png">
        </div>
    </header>

    <form id="form1" runat="server">
        <div>
        </div>
    </form>

    <footer>
        <div id="Footer">
            <p id="FooterText">This website uses the <a href="https://crackwatch.com" target="_blank" />Crackwatch API </p>
        </div>
    </footer>
</body>
</html>
