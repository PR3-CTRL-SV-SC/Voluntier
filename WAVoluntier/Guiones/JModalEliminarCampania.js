const notificacion = document.getElementById('modalNotificacion');
const notificacionContainer = document.getElementById('modalNotificacionContainer');
const cerrarNotificacion = document.getElementById('btnCerrar');

function Abrir() {
    notificacionContainer.classList.add('show');
    notificacion.classList.add('show');
}

function Cerrar() {
    notificacion.classList.remove('show');
    notificacionContainer.classList.remove('show');
}