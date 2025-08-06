<head>
    <style type="text/css">
        .auto-style1 {
            height: 29px;
        }
    </style>
</head>
<form id="form1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" Text="Department Name"></asp:Label>
                :</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtDepartmentID" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnSave" runat="server" BackColor="#33CC33" OnClick="btnSave_Click" Text="Save" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</form>
