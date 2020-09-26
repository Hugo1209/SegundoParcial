$(function(){
    cargaUsuarios();   
        
});

function cargaUsuarios(){
    $.ajax({
        method: "GET",
        url:"https://api.github.com/users/"+"",
            success:function(usu)
            {
                console.log(usu);
                render(usu); 
            }
        });   
}  


function render (usu)
{
    for (var i=0; i>usu.length; i++)
    {
        console.log(usu[i])   
    } 
} 

