:root {
  --bg-color: #0c1a2e;
  --card-color: #1a2c42;
  --text-color: #e0f2ff;
  --accent-color: #007bff;
  --border-color: #3d5a80;
  --input-bg: #2b4055;
  --shadow-color: rgba(0,0,0,.4);
}

* { box-sizing: border-box; }

body {
  font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
  background-color: var(--bg-color);
  color: var(--text-color);
  display: flex;
  justify-content: center;
  align-items: flex-start;
  min-height: 100vh;
  margin: 0;
  padding: 20px 0;
}

.container { width: 95%; max-width: 900px; }

h1 { text-align: center; margin-bottom: 30px; }

/* Card */
.card {
  background-color: var(--card-color);
  border-radius: 10px;
  box-shadow: 0 4px 15px var(--shadow-color);
  padding: 25px;
  margin-bottom: 25px;
}

/* Tabela */
.table-wrapper { max-height: 450px; overflow-y: auto; }
.process-table { width: 100%; border-collapse: separate; border-spacing: 0; }
.process-table th, .process-table td {
  padding: 12px 15px; text-align: left; border-bottom: 1px solid var(--border-color);
}
.process-table th { position: sticky; top: 0; background-color: var(--card-color); z-index: 1; }

/* Inputs/selects */
.input-group { margin-bottom: 18px; }
.input-group label { display: block; margin-bottom: 8px; }
.input-group input, .input-group select {
  width: 100%; padding: 10px; border-radius: 6px; background-color: var(--input-bg);
  color: var(--text-color); border: 1px solid var(--border-color); font-size: 16px;
}

/* Botões */
.apply-button, .btn-primary {
  width: 100%; padding: 12px; background-color: var(--accent-color); color: #fff;
  border: none; border-radius: 6px; cursor: pointer; font-size: 16px; font-weight: 600; margin-top: 15px;
}
.apply-button:hover, .btn-primary:hover { background-color: #0056b3; }

/* FAB */
.fab-button {
  position: fixed; bottom: 25px; right: 25px; width: 60px; height: 60px; background-color: var(--accent-color);
  color: #fff; border: none; border-radius: 50%; font-size: 36px; display: flex; justify-content: center; align-items: center;
  cursor: pointer; box-shadow: 0 4px 10px var(--shadow-color); transition: background-color .3s ease; z-index: 1000;
}
.fab-button:hover { background-color: #0056b3; }

/* Modal */
.modal {
  display: none; position: fixed; z-index: 1001; inset: 0;
  background-color: rgba(0, 0, 0, 0.7);
  justify-content: center; align-items: center; padding: 20px;
}
.modal.open { display: flex; }

.modal-content { position: relative; padding: 30px; width: 90%; max-width: 500px; animation: fadeIn .3s ease-out; }
.modal-content h2 { text-align: center; margin: 0 0 25px; }

.close-button {
  position: absolute; top: 15px; right: 25px; font-size: 30px; cursor: pointer;
  background: none; border: none; color: var(--text-color); transition: color .3s ease;
}
.close-button:hover, .close-button:focus { color: #ff6b6b; }

/* Animação */
@keyframes fadeIn { from { opacity: 0; transform: scale(.98); } to { opacity: 1; transform: scale(1); } }

@media (max-width: 600px) {
  .card { padding: 15px; }
  .fab-button { width: 50px; height: 50px; font-size: 30px; bottom: 15px; right: 15px; }
}

.select-group { margin-bottom: 12px; }
