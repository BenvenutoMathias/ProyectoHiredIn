let estado;

const CambiarTema = () => {
    if(estado){
    $('#Cuerpo').removeClass("bodyWhite").removeClass("bodyDark bg-white");
    $('#navBar').removeClass("navbar-light").addClass("navbar-dark bg-black");
    estado = false;
    }else{
        estado = true;
        $('#Cuerpo').removeClass("bodyDark").addClass("bodyWhite");
    }
}