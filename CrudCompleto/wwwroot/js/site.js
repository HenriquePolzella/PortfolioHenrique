// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function formatarTelefone(elemento) {
    let valor = elemento.value.replace(/\D/g, ''); // Remove todos os caracteres que não são dígitos
    let formatado = '(' + valor.substring(0, 2) + ') ' + valor.substring(2, 11); // Aplica a máscara (99) 999999999
    elemento.value = formatado;
}
function bloquearNumeros(elemento) {
    elemento.value = elemento.value.replace(/[^a-zA-ZÀ-ú\s]/g, '');
}
const toggleButton = document.getElementById('toggleButton');
const body = document.body;

toggleButton.addEventListener('click', () => {
    body.classList.toggle('light-mode');
});