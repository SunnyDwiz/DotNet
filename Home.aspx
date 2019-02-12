<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="DotNet.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="col-md-6 col-lg-push-3">
                <div class="panel panel-success">
                    <div class="panel panel-heading">
                        <div class="panel-title">Employee Registration</div>
                    </div>
                    <div class="panel panel-body">
                        <div class="form-horizontal">Employee Name<asp:TextBox ID="txtName" runat="server" CssClass="form-control" required="true"></asp:TextBox></div>
                        <asp:RegularExpressionValidator ID="rgexName" runat="server" CssClass="label-danger" SetFocusOnError="true" ControlToValidate="txtName" ErrorMessage="Please enter name only No special charectar" ValidationExpression="^[a-zA-Z]+$"></asp:RegularExpressionValidator>
                        <div class="form-horizontal">E-Mail<asp:TextBox ID="txtMail" runat="server" CssClass="form-control" required="true"></asp:TextBox></div>
                        <asp:RegularExpressionValidator ID="rgexEmail" runat="server" CssClass="label-danger" SetFocusOnError="true" ControlToValidate="txtMail" ErrorMessage="Please Enter Valid Email ID" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Visible="true"></asp:RegularExpressionValidator>
                        <div class="form-horizontal">Phone<asp:TextBox ID="txtMobile" runat="server" CssClass="form-control" required="true"></asp:TextBox></div>
                        <asp:RegularExpressionValidator ID="rgexMobile" runat="server" CssClass="label-danger" SetFocusOnError="true" ControlToValidate="txtMobile" ErrorMessage="Please enter 10 digit Mobile Number" ValidationExpression="^\d{10}$"></asp:RegularExpressionValidator>
                        <div class="form-horizontal">State</div>
                        <div class="form-horizontal">
                            Select State<asp:DropDownList ID="drpState" required="true" CssClass="form-control" runat="server" AutoPostBack="true" OnSelectedIndexChanged="drpState_SelectedIndexChanged">
                                <asp:ListItem>Select Any State</asp:ListItem>
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator InitialValue="-1" ID="Req_ID" Display="Dynamic"
                                ValidationGroup="g1" runat="server" ControlToValidate="drpState"
                                ErrorMessage="Select one state"></asp:RequiredFieldValidator>
                        </div>

                        <div class="form-horizontal">
                            City<asp:DropDownList ID="drpCity" CssClass="form-control" runat="server">
                                <asp:ListItem>Select Any City</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="form-horizontal has-warning">Religion</div>
                        <div class="form-horizontal">
                            <asp:RadioButton ID="rdHindu" runat="server" GroupName="rel" Text="Hindu" CssClass="radio-inline" />
                            <asp:RadioButton ID="rdMuslim" runat="server" GroupName="rel" Text="Muslim" CssClass="radio-inline" />
                            <asp:RadioButton ID="rdChrist" runat="server" GroupName="rel" Text="Christian" CssClass="radio-inline" />
                        </div>
                        <div class="form-horizontal has-warning">Gender</div>
                        <div class="form-horizontal">
                            <asp:RadioButton ID="rdMale" runat="server" GroupName="gen" Text="Male" CssClass="radio-inline" />
                            <asp:RadioButton ID="rdFemale" runat="server" GroupName="gen" Text="Female" CssClass="radio-inline" />
                        </div>
                        <div class="form-horizontal has-warning">Skill</div>
                        <div class="form-horizontal">
                            <asp:CheckBox ID="chkCsharp" runat="server" Text="Dot Net" CssClass="checkbox-inline" />
                            <asp:CheckBox ID="chkWeb" runat="server" Text="Web Technologies" CssClass="checkbox-inline" />
                            <asp:CheckBox ID="chkBoostrap" runat="server" Text="Boostrap" CssClass="checkbox-inline" />
                            <asp:CheckBox ID="chkSql" runat="server" Text="SQL Server" CssClass="checkbox-inline" />
                        </div>
                        <div class="form-group">
                            <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass=" col-sm-2 col-lg-push-4 btn btn-success" OnClick="btnSubmit_Click" />
                        </div>
                    </div>
                    <div class="panel-footer">
                    </div>
                </div>
            </div>
            <div class="col-lg-4">
                
            </div> 
            </div>
    </form>
</body>
</html>
