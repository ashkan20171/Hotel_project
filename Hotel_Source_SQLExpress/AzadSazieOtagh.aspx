<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AzadSazieOtagh.aspx.cs" Inherits="AzadSazieOtagh" Title="Untitled Page" %>

<%@ Register Src="MainAdminCheker.ascx" TagName="MainAdminCheker" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="margin-top: 10px; margin-bottom: 10px" width="100%">
        <tr>
            <td colspan="3" style="text-align: center">
                <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="14pt"
                    ForeColor="#0000C0" Style="margin-top: 20px" Text="صفحه تسویه حساب و ثبت خروج مشتری"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="3" style="text-align: center">
                <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#FF0066"
                    Text="Label" Visible="False"></asp:Label></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="8pt"
                    Text="کد اتاق:"></asp:Label></td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Font-Names="Tahoma"
                    Font-Size="8pt" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="140px" ValidationGroup="8">
                </asp:DropDownList></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DropDownList1"
                    ErrorMessage="کد اتاق انتخاب نشده است" ValidationGroup="8">*</asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="8pt"
                    Text="تاریخ ورود به اتاق:"></asp:Label></td>
            <td style="text-align: right" dir="ltr">
                <asp:TextBox ID="TextBox1" runat="server" Enabled="False" Font-Bold="True" Font-Names="Tahoma"
                    Font-Size="8pt" ValidationGroup="8"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1"
                    ErrorMessage="تاریخ تحویل اتاق به مشتری وارد نشده است" ValidationGroup="8">*</asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="8pt"
                    Text="بیعانه پرداختی مشتری:"></asp:Label></td>
            <td style="text-align: right">
                <asp:TextBox ID="TextBox2" runat="server" Enabled="False" Font-Bold="True" Font-Names="Tahoma"
                    Font-Size="8pt" ValidationGroup="8"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox2"
                    ErrorMessage="حداقل مقدار بیعانه صفر می باشد" ValidationGroup="8">*</asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="8pt"
                    Text="تاریخ خروج:"></asp:Label></td>
            <td style="text-align: right" dir="ltr">
                <asp:TextBox ID="TextBox3" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="8pt" ValidationGroup="8"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox3"
                    ErrorMessage="تاریخ خروج مشتری وارد نشده است" ValidationGroup="8">*</asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="8pt"
                    Text="تعداد روزهای اقامت:"></asp:Label></td>
            <td style="text-align: right">
                <asp:TextBox ID="TextBox4" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="8pt" ValidationGroup="8"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox4"
                    ErrorMessage="تعداد روزهای اقامت وارد نشده است" ValidationGroup="8">*</asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="8pt"
                    Text="مبلغ هر شب اقامت:"></asp:Label></td>
            <td style="text-align: right">
                <asp:TextBox ID="TextBox5" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="8pt" ValidationGroup="8"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox5"
                    ErrorMessage="مبلغ هر شب اقامت وارد نشده است" ValidationGroup="8">*</asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="8pt"
                    Text="کل هزینه اقامت مشتری:"></asp:Label></td>
            <td style="text-align: right">
                <asp:TextBox ID="TextBox6" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="8pt" ValidationGroup="8"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox6"
                    ErrorMessage="کل هزینه های اقامت محاسبه نشده است" ValidationGroup="8">*</asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="8pt"
                    Text="هزینه سایر خدمات:"></asp:Label></td>
            <td style="text-align: right">
                <asp:TextBox ID="TextBox7" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="8pt" ValidationGroup="8"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox7"
                    ErrorMessage="حداقل هزینه سایر خدمات صفر می باشد" ValidationGroup="8">*</asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="8pt"
                    Text="تخفیف:"></asp:Label></td>
            <td style="text-align: right">
                <asp:TextBox ID="TextBox8" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="8pt" ValidationGroup="8"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBox8"
                    ErrorMessage="حداقل مقدار تخفیف صفر می باشد" ValidationGroup="8">*</asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="8pt"
                    Text="کل مبلغ قابل پرداخت:"></asp:Label></td>
            <td style="text-align: right">
                <asp:TextBox ID="TextBox9" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="8pt" ValidationGroup="5"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TextBox9"
                    ErrorMessage="کل مبلغ قابل پرداخت وارد نشده است" ValidationGroup="5">*</asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="8pt"
                    Height="26px" Text="محاسبه" Width="82px" OnClick="Button1_Click" ValidationGroup="8" />&nbsp;<asp:Button ID="Button2" runat="server"
                        Font-Bold="True" Font-Names="Tahoma" Font-Size="8pt" Height="26px" OnClick="Button2_Click"
                        Text="ثبت" Width="82px" ValidationGroup="5" /></td>
            <td>
            </td>
        </tr>
        <tr>
            <td colspan="3" style="text-align: center">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Size="8pt" ValidationGroup="5" />
                <asp:ValidationSummary ID="ValidationSummary2" runat="server" Font-Names="Tahoma"
                    Font-Size="8pt" ValidationGroup="8" />
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td colspan="3" style="text-align: center">
                <asp:Image ID="Image1" runat="server" Height="163px" ImageUrl="~/images/discount1.jpg"
                    Width="167px" /></td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
    </table>
    <uc1:MainAdminCheker ID="MainAdminCheker1" runat="server" />
</asp:Content>

