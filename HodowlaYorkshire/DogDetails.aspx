<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DogDetails.aspx.cs" Inherits="HodowlaYorkshire.DogDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:FormView ID="DogDetail" runat="server" ItemType="HodowlaYorkshire.Models.Dog" SelectMethod="GetDog" RenderOuterTable="false">
            <ItemTemplate>
                <div>
                    <h1><%#:Item.Name %></h1>
                </div>
                <br />
                <table>
                    <tr>
                        <td>
                            <img src="/Images/<%#:Item.PrimaryImagePath %>" style="border:solid; height:300px"/>
                        </td>
                        <td>&nbsp;</td>
                        <td style="vertical-align:top; text-align:left">
                            <b>Name: <%#:Item.Name %></b>
                            <br />
                            <span><b>Description: <%#:Item.Description %></b></span>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:FormView>
        <br />
    </div>
    <div>
        <asp:Panel ID="ImagePanel" runat="server" ScrollBars="Horizontal" ></asp:Panel>
        <br />
    </div>
</asp:Content>
