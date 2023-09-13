var texto = "";
var teclaNumerico = new Array("1", "2", "3", "4", "5", "6", "7", "8", "9", "0");
var z = 0;
var mayus = true

function anadir(nums) {
    texto = document.getElementById('ContentPlaceHolder1_cuAutenticar_txtPIN').value;    
    if (texto.length < 6) {
        if (nums == "\b") {
            numeroLetras = texto.length - 1
            texto = texto.substring(0, numeroLetras);
        }
        else {
            if (!mayus) {
                nums = nums.toLowerCase()
            }
            texto = texto + nums;
        }
        document.getElementById('ContentPlaceHolder1_cuAutenticar_txtPIN').value = texto;
        document.getElementById('ContentPlaceHolder1_cuAutenticar_hddPIN').value = texto;        
    }

    //cambiarNumeros();
}

function limpiar() {
    document.getElementById('ContentPlaceHolder1_cuAutenticar_txtPIN').value = "";
}

function cambiarNumeros() {
    var nuevoArreglo = teclaNumerico.slice();
    var longitud = nuevoArreglo.length;
    var i = longitud;

    while (i--) {
        var p = parseInt(Math.random() * longitud);
        var t = nuevoArreglo[i];
        nuevoArreglo[i] = nuevoArreglo[p];
        nuevoArreglo[p] = t;
    }

    teclaNumerico = nuevoArreglo;
    if (teclaNumerico.length > 0) {        
        document.getElementById('btn1').src = "../Imagenes/LoginBotonera/" + teclaNumerico[0] + ".png";
        document.getElementById('btn2').src = "../Imagenes/LoginBotonera/" + teclaNumerico[1] + ".png";
        document.getElementById('btn3').src = "../Imagenes/LoginBotonera/" + teclaNumerico[2] + ".png";
        document.getElementById('btn4').src = "../Imagenes/LoginBotonera/" + teclaNumerico[3] + ".png";
        document.getElementById('btn5').src = "../Imagenes/LoginBotonera/" + teclaNumerico[4] + ".png";
        document.getElementById('btn6').src = "../Imagenes/LoginBotonera/" + teclaNumerico[5] + ".png";
        document.getElementById('btn7').src = "../Imagenes/LoginBotonera/" + teclaNumerico[6] + ".png";
        document.getElementById('btn8').src = "../Imagenes/LoginBotonera/" + teclaNumerico[7] + ".png";
        document.getElementById('btn9').src = "../Imagenes/LoginBotonera/" + teclaNumerico[8] + ".png";
        document.getElementById('btn0').src = "../Imagenes/LoginBotonera/" + teclaNumerico[9] + ".png";
    }

    var numeros1 = "";
    var p1 = 0;
    for (a = 0; a < teclaNumerico.length; a++) {
        /*numeros1 = numeros1 + "<input id='btn" + teclaNumerico[a] + "' style='width:30px;' type='Button' value=" + teclaNumerico[a] + " onclick=anadir('" + teclaNumerico[a] + "') onmouseover=cambiarVista() onmouseout=restablecerVista()>&nbsp;";*/
        numeros1 = numeros1 + "<img id='btn" + teclaNumerico[a] + "' alt=" + teclaNumerico[a] + " src='../Imagenes/LoginBotonera/" + teclaNumerico[a] + ".png' onclick=anadir('" + teclaNumerico[a] + "') onmouseover=cambiarVista() onmouseout=restablecerVista()  />&nbsp;";
        p1 = p1 + 1;
        if (p1 == 4) {
            p1 = 0;
            numeros1 = numeros1 + "<br/><br/>";
        }
        if (a >= 9) {
            numeros1 = numeros1 + "<img id='btnLimpiar' alt='' src='../Imagenes/LoginBotonera/Limpiar.png' onclick='limpiar()'/>&nbsp;";
        }
    }
    document.getElementById('botones').innerHTML = numeros1;

}

var uno = "";
var dos = "";
var tres = "";
var cuatro = "";
var cinco = "";
var seis = "";
var siete = "";
var ocho = "";
var nueve = "";
var cero = "";

function cambiarVista() {
    guardarDatos();
    document.getElementById('btn1').src = "../Imagenes/LoginBotonera/Asterisco.png";
    document.getElementById('btn2').src = "../Imagenes/LoginBotonera/Asterisco.png";
    document.getElementById('btn3').src = "../Imagenes/LoginBotonera/Asterisco.png";
    document.getElementById('btn4').src = "../Imagenes/LoginBotonera/Asterisco.png";
    document.getElementById('btn5').src = "../Imagenes/LoginBotonera/Asterisco.png";
    document.getElementById('btn6').src = "../Imagenes/LoginBotonera/Asterisco.png";
    document.getElementById('btn7').src = "../Imagenes/LoginBotonera/Asterisco.png";
    document.getElementById('btn8').src = "../Imagenes/LoginBotonera/Asterisco.png";
    document.getElementById('btn9').src = "../Imagenes/LoginBotonera/Asterisco.png";
    document.getElementById('btn0').src = "../Imagenes/LoginBotonera/Asterisco.png";
}

function guardarDatos() {
    
    if (document.getElementById('btn1').src == "../Imagenes/LoginBotonera/Asterisco.png") {
    
        document.getElementById('btn1').src = "../Imagenes/LoginBotonera/1.png";
        document.getElementById('btn2').src = "../Imagenes/LoginBotonera/2.png";
        document.getElementById('btn3').src = "../Imagenes/LoginBotonera/3.png";
        document.getElementById('btn4').src = "../Imagenes/LoginBotonera/4.png";
        document.getElementById('btn5').src = "../Imagenes/LoginBotonera/5.png";
        document.getElementById('btn6').src = "../Imagenes/LoginBotonera/6.png";
        document.getElementById('btn7').src = "../Imagenes/LoginBotonera/7.png";
        document.getElementById('btn8').src = "../Imagenes/LoginBotonera/8.png";
        document.getElementById('btn9').src = "../Imagenes/LoginBotonera/9.png";
        document.getElementById('btn0').src = "../Imagenes/LoginBotonera/0.png";
    }
    else {
        uno = document.getElementById('btn1').src;
        dos = document.getElementById('btn2').src;
        tres = document.getElementById('btn3').src;
        cuatro = document.getElementById('btn4').src;
        cinco = document.getElementById('btn5').src;
        seis = document.getElementById('btn6').src;
        siete = document.getElementById('btn7').src;
        ocho = document.getElementById('btn8').src;
        nueve = document.getElementById('btn9').src;
        cero = document.getElementById('btn0').src;
    }
}

function restablecerVista() {
    document.getElementById('btn1').src = uno;
    document.getElementById('btn2').src = dos;
    document.getElementById('btn3').src = tres;
    document.getElementById('btn4').src = cuatro;
    document.getElementById('btn5').src = cinco;
    document.getElementById('btn6').src = seis;
    document.getElementById('btn7').src = siete;
    document.getElementById('btn8').src = ocho;
    document.getElementById('btn9').src = nueve;
    document.getElementById('btn0').src = cero;
}

function DisableCtrlKey(e) {
    var code = (document.all) ? event.keyCode : e.which;
    //var message = "No se puede pegar a este Cuatro de texto";
    // look for CTRL key press
    if (parseInt(code) == 17) {
        //alert(message); 
        window.event.returnValue = false;
    }
}