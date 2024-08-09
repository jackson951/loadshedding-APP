<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Info.aspx.cs" Inherits="KHUTO_39990966.Info" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #00FFFF">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Potchefstroom Load Shedding Schedule Survival Guide</h1>
            <p>
                <asp:Label ID="lblGreeting" runat="server" Font-Size="X-Large" Text="greeting"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
        </div>
        <asp:Label ID="lblZone" runat="server" Text="zone"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        <br />

        <h3>Today's load shedding forecast:</h3>
        <p>
            <asp:Label ID="lblMessage" runat="server" Text="message"></asp:Label>
&nbsp;&nbsp;&nbsp; </p>
        <p>
            <asp:Label ID="lblSchedule" runat="server" Font-Size="X-Large" Text="Scedule"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</p>
        <asp:Button ID="btnHome" runat="server" BackColor="Lime" OnClick="btnHome_Click" Text="Home" />
    </form>
</body>
</html>
