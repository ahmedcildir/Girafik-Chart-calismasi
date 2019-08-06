<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Grafik.aspx.cs" Inherits="Grafik_Ornek.Grafik" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Haftalık Grafik</h2>
            <asp:Chart ID="Chart1" runat="server" Height="344px" Width="571px">
                <Series>
                    <asp:Series Name="veri1">
                    </asp:Series>
                    <asp:Series ChartArea="ChartArea1" Name="veri2">
                    </asp:Series>
                    <asp:Series ChartArea="ChartArea1" Name="veri3">
                    </asp:Series>
                    <asp:Series ChartArea="ChartArea1" Name="veri4">
                    </asp:Series>
                    <asp:Series ChartArea="ChartArea1" Name="veri5">
                    </asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </ChartAreas>
            </asp:Chart>
        </div>

        <div>
            <h2>Aylık Grafik</h2>
            <asp:Chart ID="Chart2" runat="server" Height="344px" Width="571px">
                <Series>
                    <asp:Series Name="veri1" ChartType="Line">
                    </asp:Series>
                    <asp:Series ChartArea="ChartArea1" Name="veri2" ChartType="Line">
                    </asp:Series>
                    <asp:Series ChartArea="ChartArea1" Name="veri3" ChartType="Line">
                    </asp:Series>
                    <asp:Series ChartArea="ChartArea1" Name="veri4" ChartType="Line">
                    </asp:Series>
                    <asp:Series ChartArea="ChartArea1" Name="veri5" ChartType="Line">
                    </asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </ChartAreas>
            </asp:Chart>
        </div>
    </form>
</body>
</html>
