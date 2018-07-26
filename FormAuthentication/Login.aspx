<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FormAuthentication.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <label for="name">Name</label>
                <input id="name" name="name" />
            </div>
            <div>
                <label for="pass">Password</label>
                <input id="pass" />
            </div>
            <input type="submit" />
        </div>
    </form>
</body>
</html>
