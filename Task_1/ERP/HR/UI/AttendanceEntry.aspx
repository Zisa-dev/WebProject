<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AttendanceEntry.aspx.cs" Inherits="HR.UI.AttendanceEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Attendance Entry:</title>
    <style>
        body {
            margin: 0;
            height: 100vh;
            background-color: #f0f8ff; /* Light background */
            display: flex;
            align-items: center;
            justify-content: center;
            font-family: Arial;
        }

        .form-container {
            background-color: white;
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0 4px 12px rgba(0, 0, 0, 0.2);
        }

        td {
            padding: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
         <div class="form-title">Attendence Entry</div>

            <table class="form_title">
                <tr>
                    <td>Employee ID:</td>
                    <td>
                        <asp:TextBox ID="txtEmployeeID" runat="server" BorderStyle="Solid"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Date:</td>
                    <td>
                        <asp:TextBox ID="txtDate" runat="server" TextMode="Date" BorderStyle="Solid"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Time In:</td>
                    <td>
                        <asp:TextBox ID="txtTimeIn" runat="server" TextMode="Time" BorderStyle="Solid"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Time Out:</td>
                    <td>
                        <asp:TextBox ID="txtTimeOut" runat="server" TextMode="Time" BorderStyle="Solid"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Status:</td>
                    <td>
                        <asp:TextBox ID="txtStatus" runat="server" TextMode="Time" BorderStyle="Solid"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSave" runat="server" Text="Save" BackColor="#00CCFF" OnClick="btnSave_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

