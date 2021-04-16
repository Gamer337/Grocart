
Partial Class Site
    Inherits System.Web.UI.MasterPage

    Protected Sub NavigationMenu_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles NavigationMenu.MenuItemClick
        Response.Redirect("pedit.aspx")

    End Sub
End Class

