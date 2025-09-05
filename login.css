// Credenciais DEMO (não usar em produção)
const DEMO_USER = { username: "admin", password: "1234" };

// Se já está logado, vai direto para a aplicação
if (localStorage.getItem("auth_token")) {
  window.location.href = "index.html";
}

// Refs
const form = document.getElementById("login-form");
const userInput = document.getElementById("username");
const passInput = document.getElementById("password");
const remember = document.getElementById("remember");
const errorEl = document.getElementById("error");
const toggleBtn = document.getElementById("toggle-pass");
const fillDemo = document.getElementById("fill-demo");

// Mostrar/ocultar senha
toggleBtn.addEventListener("click", () => {
  const type = passInput.getAttribute("type") === "password" ? "text" : "password";
  passInput.setAttribute("type", type);
});

// Preenche com demo
fillDemo.addEventListener("click", (e) => {
  e.preventDefault();
  userInput.value = DEMO_USER.username;
  passInput.value = DEMO_USER.password;
  passInput.focus();
});

// “Lembrar usuário”
const savedUser = localStorage.getItem("last_username");
if (savedUser) userInput.value = savedUser;

// Submeter login
form.addEventListener("submit", (e) => {
  e.preventDefault();
  errorEl.textContent = "";

  const u = userInput.value.trim();
  const p = passInput.value;

  // Validação DEMO
  const ok = (u === DEMO_USER.username && p === DEMO_USER.password);

  if (!ok) {
    errorEl.textContent = "Usuário ou senha inválidos.";
    return;
  }

  // Salva “sessão” simples
  localStorage.setItem("auth_token", `token_${Date.now()}`); // token fake
  if (remember.checked) {
    localStorage.setItem("last_username", u);
  } else {
    localStorage.removeItem("last_username");
  }

  // Vai para o app
  window.location.href = "index.html";
});
