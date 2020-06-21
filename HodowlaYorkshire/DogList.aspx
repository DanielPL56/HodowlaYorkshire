<%@ Page Title="Dogs" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DogList.aspx.cs" Inherits="HodowlaYorkshire.DogList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <div>
            <hgroup>
                <h2></h2>
            </hgroup>

            <asp:ListView ID="dogList" runat="server" DataKeyNames="DogId" GroupItemCount ="4" ItemType="HodowlaYorkshire.Models.Dog"  SelectMethod="GetDogs">
                <EmptyDataTemplate>
                    <table>
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
                    <td></td>
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceHolderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <td runat="server">
                        <table>
                            <tr>
                                <td>
                                    <a href="DogDetails.aspx?DogId=<%#:Item.DogId %>">
                                        <img src="Images/<%#:Item.PrimaryImagePath %>" width="200" height="200" style="border:solid" />
                                    </a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <a href="DogDetails.aspx?DogId=<%#:Item.DogId %>">
                                        <span><b><%#:Item.Name %></b></span>
                                    </a>
                                    <br />
                                    <span>
                                        <b>Description: </b><%#:Item.Description%>
                                    </span>
                                    <br />
                                    <span><b>Breed: <%#:Item.Breed.BreedName %></b></span>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table style="width:100%">
                        <tbody>
                            <tr>
                                <td>
                                    <table id="groupPlaceholderContainer" runat="server" style="width:100%">
                                        <tr id="groupPlaceholder"></tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                            </tr>
                        </tbody>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
        </div>
    </section>
</asp:Content>
