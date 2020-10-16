﻿<%@ Page Title="My Music" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MusicList.aspx.cs" Inherits="MusicWebsite.MusicList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <div>
            <hgroup>
                <h2><%: Page.Title %></h2>
            </hgroup>

            <asp:ListView ID="musicList" runat="server" DataKeyNames="MusicID" GroupItemCount="4"
                ItemType="MusicWebsite.Models.Music" SelectMethod="GetMusics">
                <EmptyDataTemplate>
                    <table>
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
                    <td />
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <td runat="server">
                        <table>
                            <tr>
                                <td>
                                    <a href="MusicDetails.aspx?musicID=<%#:Item.MusicID %>">
                                        <img src="/Album/Images/Thumbs/<%#:Item.ImagePath %>" width="100" height="75" style="border:solid" />
                                    </a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <a href="MusicDetails.aspx?musicID=<%#:Item.MusicID%>">
                                        <span class="MusicName">
                                            <%#:Item.MusicName%>
                                        </span>
                                    </a>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        </p>
                    </td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table style="width:100%;">
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
                            <tr></tr>
                        </tbody>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
        </div>
    </section>
</asp:Content>
