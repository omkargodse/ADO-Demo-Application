<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ADODatabaseDemo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <asp:GridView ID="GridView1" runat="server">

    </asp:GridView><br />
    <Table>
        <tr>
            <td>ID</td>
            <td>
                <asp:TextBox runat="server" ID="TxtID">

                </asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Name</td>
            <td><asp:TextBox runat="server" ID="TxtName">

            </asp:TextBox></td>
        </tr>
        <tr>
            <td>Address</td>
            <td><asp:TextBox runat="server" ID="TxtAddress">

            </asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Button  OnClick="SaveData" ID="btnSave" runat="server" Text="Save"/></td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblStdID"></asp:Label>
            </td>
        </tr>
        
    </Table>

</asp:Content>
