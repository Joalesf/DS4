<form id="form1" runat="server">
    <div style="text-align:center; margin-top:50px;">
        <h3>Introduzca un Texto</h3>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Button ID="btnSaludo" runat="server" Text="Enviar Saludo!" OnClick="btnSaludo_Click" />
        <br /><br />
        <asp:Label ID="lblSaludo" runat="server" Text=""></asp:Label>
    </div>
</form>
