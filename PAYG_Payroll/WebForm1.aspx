<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PAYG_Payroll.WebForm1" %>

<%@ Register Assembly="DayPilot" Namespace="DayPilot.Web.Ui" TagPrefix="DayPilot" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <div>
        
        <DayPilot:DayPilotCalendar ID="DayPilotCalendar1" runat="server" BackColor="#FFFFD5" BorderColor="#000000" BusinessBeginsHour="0" BusinessEndsHour="24" ColumnMarginRight="1" CssClassPrefix="calendar_default" DataEndField="end" DataIdField="" DataSourceID="SqlDataSource1" DataStartField="start" DataTextField="name" DataValueField="hsa_grid_id" DayFontFamily="Tahoma" DayFontSize="10" Days="7" DurationBarColor="Blue" EventBackColor="#FFFFFF" EventBorderColor="#000000" EventClickHandling="PostBack" EventFontFamily="Tahoma" EventFontSize="8pt" EventHoverColor="#DCDCDC" HourBorderColor="#EAD098" HourFontFamily="Tahoma" HourFontSize="16pt" HourHalfBorderColor="#F3E4B1" HourNameBackColor="#ECE9D8" HourNameBorderColor="#ACA899" HoverColor="#FFED95" NonBusinessBackColor="#FFF4BC" OnEventClick="DayPilotCalendar1_EventClick" ScrollPositionHour="9" ShowEventStartEnd="True" StartDate="2015-04-06" style="top: 0px; left: 0px; width: 1047px; height: 849px" TimeFormat="Auto" />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:payg_main_dbConnectionString %>" SelectCommand="SELECT * FROM [hsa]"></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
