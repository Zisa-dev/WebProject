<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LeaveEntry.aspx.cs" Inherits="HR.UI.LeaveEntry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Employee ID :"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtEmployeeID" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="No of Days :"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtNoOfDays" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label3" runat="server" Text="From Date :"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtFromDate" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label4" runat="server" Text="To Date :"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtToDate" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="btnSave" CssClass="button-1" runat="server" Text="Save" />
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
