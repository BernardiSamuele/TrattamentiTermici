﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="scada.aspx.cs" Inherits="SCADA_CSharp.scada" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%-- Qui inserisco i controlli che non devono essere ricaricati al timer.tick --%>
            <asp:Button ID="btnConnect" runat="server" OnClick="btnConnect_Click" Text="Connect" />
            <asp:Button ID="btnDisconnect" runat="server" OnClick="btnDisconnect_Click" Text="Disconnect" />
            <asp:Label ID="lblConnect" runat="server"></asp:Label>
            <br /><br /><br /><br /><br />
            
            <br />
            <br />
            <asp:Button ID="btnAuto" runat="server" Text="AUTO" OnClick="btnAuto_Click" />
            <br />
            <asp:Button ID="btnIni1" runat="server" Text="bIni1" OnClick="btnIni1_Click" />
            <br />
            <asp:Button ID="btnAttesaStop" runat="server" Text="Attesa stop" OnClick="btnAttesaStop_Click" />
            <br />
            <asp:Button ID="btnMan" runat="server" Text="MAN" OnClick="btnMan_Click" style="height: 26px" />
            <br />
            <asp:Button ID="btnStop" runat="server" OnClick="btnStop_Click" Text="STOP" />
            <br />
            <asp:Button ID="btnAttivaEmergenza" runat="server" Text="Attiva Emergenza" OnClick="btnAttivaEmergenza_Click" />
            <br />
            <asp:Button ID="btnReset" runat="server" Text="RESET" OnClick="btnReset_Click" />
            <br /><br /><br /><br /><br />

            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <%-- Qui inserisco i controlli che devo ricaricare al timer.tick --%>
                    <img src="img/TrattamentiTermici.png"/>
                </ContentTemplate>
            </asp:UpdatePanel>
            <br />
            <br />
            <asp:Label ID="lblMessaggio" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
