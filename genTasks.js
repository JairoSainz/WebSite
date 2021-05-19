

function getTasks() {
    let tasksView = document.getElementById('tasks');
    tasksView.innerHTML = '';
    //Add Tasks
    var num = '<%=Session["Numero"]%>';
    var title = '<%=Session["Titulo"]%>';
    var desc = '<%=Session["Descripcion"]%>';
    var mate = '<%=Session["Materia"]%>';

    for (let i = 0; i < num; i++) { 
        //Cuadro de Notas
        tasksView.innerHTML += `<div class="card mb-3">
        <div class="card-body">
          <p class="font-weight-bold"><big>${title} - <span class="badge badge-primary">${mate}</span></p><p></big>${desc}
            <br>
            <br>
            <br>
           <a href="#" onclick="editTask('${title}, ${description}')" class="btn btn-success">Editar</a>
           <a href="#" onclick="" class="btn btn-info">Materia</a>
           <a href="#" onclick="deleteTask('${title}')" class="btn btn-danger ml-5">Delete</a>
          </p>
        </div>
      </div>`;

    }
}
getTasks();