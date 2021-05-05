var inputNombre = document.getElementById('nombre');
var inputApellido = document.getElementById('apellido');
var inputEdad = document.getElementById('edad');
var inputEmpresa = document.getElementById('empresa');
var labelNombre = document.getElementById('alert__nombre')
var labelApellido = document.getElementById('alert__apellido');
var labelEdad = document.getElementById('alert__edad');

function validar(e){

    e.preventDefault();

    if (inputNombre.value.length == 0){
        labelNombre.style.visibility = "visible";
    }
    else{
        labelNombre.style.visibility = "hidden";
    }

    if (inputApellido.value.length == 0){
        labelApellido.style.visibility = "visible"
    }
    else{
        labelApellido.style.visibility = "hidden";
    }

    if(inputEdad.value < 18 ){
        labelEdad.style.visibility = "visible";
    }
    else{
        labelEdad.style.visibility = "hidden";
    }
}

function limpiar(){
    inputNombre.value = '';
    inputApellido.value = '';
    inputEdad.value = '';
    inputEmpresa.value = '';
}