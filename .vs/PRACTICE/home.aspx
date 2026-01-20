<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="PRACTICE.home" MasterPageFile="~/Site1.Master" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Home Page"></asp:Label>
            <br />
            <br />
            <br />
            Your Email :&nbsp;&nbsp;
            <asp:Label ID="em" runat="server" Text="em"></asp:Label>
            <br />
            <br />
            <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/XMLFile1.xml" />
            <br />
            <br />
            <br />
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            <br />
            CALENDER :&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="DATE WITH DAY"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
            <br />
            <br />
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <br />
                <asp:View ID="View1" runat="server">
                    =&gt;this is view 1<br />
                    <asp:Button ID="next" runat="server" OnClick="next_Click" Text="Next" />
                </asp:View>
                <br />
                <br />
                <asp:View ID="View2" runat="server">
                    =&gt;this is view 2 -----------------------------------<br />
                    <asp:Button ID="back" runat="server" OnClick="back_Click" Text="back" />
                </asp:View>
                <br />
                <br />
            </asp:MultiView>
            <br />
            <br />
            <br />
            <br />

        </div>
   
</asp:Content>


