const notificacionContainer = document.getElementById('modalNotificacionContainer');
const notificacion = document.getElementById('modalNotificacion');
const cerrarNotificacion = document.getElementById('btnCancelar');

function Abrir() {
    notificacionContainer.classList.add('show');
    notificacion.classList.add('show');
}

function Cerrar() {
    notificacion.classList.remove('show');
    notificacionContainer.classList.remove('show');
}