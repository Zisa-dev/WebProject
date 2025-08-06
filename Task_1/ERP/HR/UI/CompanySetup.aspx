<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompanySetup.aspx.cs" Inherits="HR.UI.CompanySetup" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Company Setup</title>
    <style>
        body {
            margin: 0;
            height: 100vh;
            background-color: #f5f5f5;
            display: flex;
            align-items: center;
            justify-content: center;
            font-family: Arial, sans-serif;
        }

        .form-container {
            background-color: #ffffff;
            padding: 30px 40px;
            border-radius: 10px;
            box-shadow: 0 4px 12px rgba(0, 0, 0, 0.2);
        }

        td {
            padding: 10px;
            font-size: 14px;
        }

        input[type="text"] {
            width: 100%;
        }

        .button-cell {
            text-align: center;
        }
        .auto-style1 {
            height: 47px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">

            <table class="form-container">
                <tr>
                    <td>Company Name:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtName" runat="server" BorderStyle="Solid" Width="251px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>About:</td>
                    <td>
                        <asp:TextBox ID="txtAbout" runat="server" BorderStyle="Solid"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Status:</td>
                    <td>
                        <asp:TextBox ID="txtStatus" runat="server" BorderStyle="Solid"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" class="button-cell">
                        <asp:Button ID="btnSave" runat="server" Text="Save" BackColor="#00CCFF" OnClick="btnSave_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

