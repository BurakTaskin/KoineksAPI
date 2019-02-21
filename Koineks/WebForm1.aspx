<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Koineks.WebForm1"%>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <script type="text/javascript">
    function sure() {

        var product = { 
               "short_code": "BTC",
                "name": "Bitcoin", 
            }; 

        $.ajax({ 
                type: "POST", 
                url: "https://koineks.com/ticker", 
                data: JSON.stringify(product), 
                contentType: "application/json; charset=utf-8", 
                dataType: "json", 
                success: function (data) { 
                    alert(data.current);  
                }, 
                error: function (xmlRequest,status,errorThrown) { 
                    alert("ajax isteği hatalı"); 
                } 
            }); 

    }
    window.setInterval(function(){
        sure();
    }, 100);
</script>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%; height: 75px">
    <tr>
        <td><br />
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            &nbsp;
        </td>
        <td><br/>
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
            &nbsp;
        </td>
    </tr>
</table>
        </div>
    </form>
</body>
</html>

