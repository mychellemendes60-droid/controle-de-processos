// Guard: se não estiver logado, redireciona para login
if (!localStorage.getItem("auth_token")) {
  window.location.href = "login.html";
}

// Opcional: sinal de vida
// alert("main.js carregado!");

(function init() {
  // Seletores
  const openModalBtn = document.getElementById('open-modal-btn');
  const addProcessModal = document.getElementById('add-process-modal');
  const closeButton = document.querySelector('.modal .close-button');
  const addProcessForm = document.getElementById('add-process-form');
  const processTableBody = document.querySelector('.process-table tbody');
  const applyButton = document.querySelector('.apply-button');
  const responsavelSelect = document.getElementById('responsavel');
  const nucleoSelect = document.getElementById('nucleo');

  // ---- Modal ----
  function openModal() {
    addProcessModal.classList.add('open');
    addProcessForm.reset();
    const first = addProcessForm.querySelector('input, select');
    if (first) first.focus();
  }
  function closeModal() {
    addProcessModal.classList.remove('open');
  }

  openModalBtn.addEventListener('click', openModal);
  closeButton.addEventListener('click', closeModal);
  addProcessModal.addEventListener('click', (e) => {
    if (e.target === addProcessModal) closeModal();
  });
  document.addEventListener('keydown', (e) => {
    if (e.key === 'Escape' && addProcessModal.classList.contains('open')) closeModal();
  });

  // ---- Adicionar nova linha ----
  addProcessForm.addEventListener('submit', (event) => {
    event.preventDefault();

    const dataDistribuicao = document.getElementById('data-distribuicao').value;
    const numeroProcesso = document.getElementById('numero-processo').value.trim();
    const materia = document.getElementById('materia').value.trim();

    if (!dataDistribuicao || !numeroProcesso || !materia) {
      alert('Preencha todos os campos.');
      return;
    }

    const newRow = processTableBody.insertRow();

    // formata dd/mm/aaaa (força horário local)
    const formattedDate = new Date(dataDistribuicao + 'T00:00:00').toLocaleDateString('pt-BR');

    newRow.insertCell().innerHTML = '<input type="checkbox" />';
    newRow.insertCell().textContent = formattedDate;
    newRow.insertCell().textContent = numeroProcesso;
    newRow.insertCell().textContent = materia;
    newRow.insertCell().textContent = 'Aguardando';
    newRow.insertCell().textContent = 'Aguardando';

    closeModal();
  });

  // ---- Aplicar em lote ----
  applyButton.addEventListener('click', () => {
    const selectedResponsavel = responsavelSelect.value;
    const selectedNucleo = nucleoSelect.value;

    const checkboxes = document.querySelectorAll('.process-table tbody input[type="checkbox"]:checked');
    if (checkboxes.length === 0) {
      alert('Selecione pelo menos uma intimação para aplicar as ações.');
      return;
    }

    checkboxes.forEach((checkbox) => {
      const row = checkbox.closest('tr');
      const cells = row.querySelectorAll('td'); // 0..5
      cells[4].textContent = selectedResponsavel;
      cells[5].textContent = selectedNucleo;
      checkbox.checked = false;
    });

    alert('Ações aplicadas com sucesso!');
  });
})();

const logoutBtn = document.getElementById('logout-btn');
if (logoutBtn) {
  logoutBtn.addEventListener('click', () => {
    localStorage.removeItem('auth_token');
    window.location.href = 'login.html';
  });
}
