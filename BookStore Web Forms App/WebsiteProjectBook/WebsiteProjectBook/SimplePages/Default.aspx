<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebsiteProjectBook.SimplePages.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="post_box">
				<div class="date_box">
                	<!--<p>30 DEC 2048</p>-->
                &nbsp;&nbsp;
                    <asp:Label ID="Label2" runat="server" Text="Label" Width="134px"></asp:Label>
                </div> <!-- end of date box -->
                
                <div class="post_body">
                       
                       <h2><a href="#">Free CSS Template</a></h2>
                       	<div class="post_info">
							by <a href="http://www.templatemo.com" target="_parent">Free CSS</a>
                        </div>
                        
                        <div class="post_content">
                            
                         <!--   <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>
                            <asp:Timer ID="Timer1" runat="server" ontick="Timer1_Tick" Interval="3000">
                            </asp:Timer>
                            <asp:updatepanel ID="BannerPannel" runat="server" UpdateMode="Conditional">
                            <Triggers>
                             <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
                            </Triggers>
                            <ContentTemplate>
                                <asp:Image ID="BannerImage" runat="server" ImageUrl="../images/templatemo_1.jpg" />&nbsp;
                            </ContentTemplate>
                            </asp:UpdatePanel>-->
                            <br />
                            
                           <a href="#"><img src="../images/templatemo_1.jpg" alt="Orange" /></a>
                          <p>Wooden Blog  is a <a href="http://www.templatemo.com/page/1" target="_parent">free website layout</a> from <a href="http://www.templatemo.com" target="_parent">templatemo.com</a>. You may download, modify and apply this template for your websites. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque eleifend ornare ipsum, eu tincidunt nunc pulvinar tincidunt. Integer vel erat purus, quis pulvinar metus. Phasellus sed orci eros.</p>
                            
                          <div class="link_button"><a href="#">Continue reading...</a><a href="#">Comments (364)</a></div>
                        </div>
                
              </div> <!-- end of post body -->
                            
            </div> <!-- end of a post -->
            
             <div class="post_box">
				<div class="date_box">
                	<!--<p>25 DEC 2048</p>-->
                </div> <!-- end of date box -->
                
                <div class="post_body">
                       
                       <h2><a href="#">Templates for your websites</a></h2>
                       	<div class="post_info">
							by <a href="http://www.templatemo.com" target="_parent">templatemo.com</a>
                        </div>
                        
                        <div class="post_content">
                            <a href="#"><img src="../images/templatemo_2.jpg" alt="Apples and Orange" /></a>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque nec dictum tortor. Etiam ultrices neque id augue rhoncus in gravida eros dictum. Integer interdum sapien id diam tempor dapibus. Aliquam lobortis nunc risus. Suspendisse sodales massa velit. Quisque odio quam, pulvinar sit amet convallis eget, venenatis ut turpis.</p>
                            
                          <div class="link_button"><a href="#">Continue reading...</a> <a href="#">Comments (542)</a></div>
                        </div>
                
               </div> <!-- end of post body -->
                            
            </div> <!-- end of a post -->

</asp:Content>
