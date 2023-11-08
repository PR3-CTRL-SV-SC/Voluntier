const notificacionContainerAceptar = document.getElementById('modalNotificacionContainerAceptar');
const notificacionAceptar = document.getElementById('modalNotificacionAceptar');

const notificacionContainerRechazar = document.getElementById('modalNotificacionContainerRechazar');
const notificacionRechazar = document.getElementById('modalNotificacionRechazar');

function AbrirAceptar() {
    notificacionContainerAceptar.classList.add('show');
    notificacionAceptar.classList.add('show');
}

function CerrarAceptar() {
    notificacionAceptar.classList.remove('show');
    notificacionContainerAceptar.classList.remove('show');
}

function AbrirRechazar() {
    notificacionContainerRechazar.classList.add('show');
    notificacionRechazar.classList.add('show');
}

function CerrarRechazar() {
    notificacionRechazar.classList.remove('show');
    notificacionContainerRechazar.classList.remove('show');
}