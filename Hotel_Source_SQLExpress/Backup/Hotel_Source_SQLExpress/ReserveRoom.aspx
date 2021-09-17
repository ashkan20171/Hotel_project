<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ReserveRoom.aspx.cs" Inherits="ReserveRoom" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" style="margin-top: 10px; margin-bottom: 10px; width: 570px">
        <tr>
            <td style="height: 21px">
            </td>
            <td style="height: 21px; text-align: center">
                <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="16pt"
                    ForeColor="#400000" Style="margin-top: 20px" Text="صفحه رزرو اتاقها"></asp:Label></td>
            <td style="height: 21px">
            </td>
        </tr>
        <tr>
            <td style="height: 21px">
            </td>
            <td style="height: 21px; text-align: center;">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="#FF0066" Text="Label"
                    Visible="False"></asp:Label></td>
            <td style="height: 21px">
            </td>
        </tr>
        <tr>
            <td style="text-align: center" colspan="3">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC"
                    BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2"
                    DataSourceID="SqlDataSource1" Font-Names="Tahoma" Font-Size="8pt" Font-Underline="False"
                    ForeColor="Black" Width="507px" AllowPaging="True" DataKeyNames="RoomID" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" PageSize="5" ShowHeader="False">
                    <RowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <table style="width: 381px">
                                    <tr>
                                        <td style="text-align: right; width: 175px;">
                                            <span style="font-size: 8pt; font-family: Tahoma"><strong>کد اتاق:</strong></span></td>
                                        <td style="text-align: right">
                                            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="False" Font-Names="Tahoma"
                                                Font-Size="8pt" Text='<%# Eval("RoomNumber") %>'></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: right; width: 175px;">
                                            <strong><span style="font-size: 8pt; font-family: Tahoma">نوع اتاق:</span></strong></td>
                                        <td style="text-align: right">
                                            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="8pt"
                                                Text='<%# Eval("RoomTypeDescription") %>'></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: right; width: 175px;">
                                            <strong><span style="font-size: 8pt; font-family: Tahoma">تعداد تخت خواب:</span></strong></td>
                                        <td style="text-align: right">
                                            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="8pt"
                                                Text='<%# Eval("RoomBed") %>'></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: right; width: 175px;">
                                            <strong><span style="font-size: 8pt; font-family: Tahoma">قیمت هر شب اقامت:</span></strong></td>
                                        <td style="text-align: right">
                                            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="8pt"
                                                Text='<%# Eval("PriceOfPerNight") %>'></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: right; width: 175px;">
                                            <strong><span style="font-size: 8pt; font-family: Tahoma">وضعیت اتاق:</span></strong></td>
                                        <td style="text-align: right">
                                            <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="8pt"
                                                Text='<%# Eval("RoomStatuseDesc") %>'></asp:Label></td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField HeaderText="رزرو" SelectText="رزرو اتاق" ShowSelectButton="True" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                    <SelectedRowStyle BackColor="White" Font-Bold="True" ForeColor="Black" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HotelConString %>"
                    SelectCommand="SELECT tblRooms.RoomID, tblRooms.RoomNumber, tblRoomTypes.RoomTypeDescription, tblRooms.RoomBed, tblRooms.PriceOfPerNight, tblRoomState.RoomStatuseDesc FROM tblRooms INNER JOIN tblRoomTypes ON tblRooms.RoomType = tblRoomTypes.RoomTypeID INNER JOIN tblRoomState ON tblRooms.RoomStatuse = tblRoomState.StatID WHERE (tblRooms.RoomStatuse = 1)">
                </asp:SqlDataSource>
                <asp:Image ID="Image1" runat="server" ImageUrl="~/images/All_Rezerved.jpg" Style="margin: 10px 200px"
                    Visible="False" /></td>
        </tr>
        <tr>
            <td>
            </td>
            <td style="text-align: center">
            </td>
            <td>
            </td>
        </tr>
    </table>
</asp:Content>

