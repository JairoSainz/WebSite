document.getElementById('formTask').addEventListener('submit', saveTask);

function saveTask(e) {
    let title = document.getElementById('title').value;
    let description = document.getElementById('description').value;
    let selectop = document.getElementById("option");
    let selected = selectop.options[selectop.selectedIndex].text;
    

    let task = {
        title,
        description,
        selected
        
        
    };
  

    if (localStorage.getItem('tasks') === null) {
        let tasks = [];
        tasks.push(task);
        localStorage.setItem('tasks', JSON.stringify(tasks));
    } else {
        let tasks = JSON.parse(localStorage.getItem('tasks'));
        tasks.push(task);
        localStorage.setItem('tasks', JSON.stringify(tasks));
    }

    getTasks();
    document.getElementById('formTask').reset();
    e.preventDefault();
}

function editTask(title) {
    let tasks = JSON.parse(localStorage.getItem('tasks'));
    title = prompt("Ingresa nuevo titulo");
    description = prompt("Ingresa nueva descripción");
    let tasksView = document.getElementById('tasks');
    tasksView.innerHTML = '';
    for (let i = 0; i < 1; i++) {
        let sop = tasks[i].selected;
        tasks[i].title = title;
        tasks[i].description = description;
        //Cuadro de Notas
        tasksView.innerHTML += `<div class="card mb-3">
        <div class="card-body">
          <p class="font-weight-bold"><big>${title} - <span class="badge badge-primary">${sop}</span></p><p></big>${description}
            <br>
            <br>
            <br>
          </p>
        </div>
      </div>`;
    }
    localStorage.setItem('tasks', JSON.stringify(tasks));
    getTasks();
}

function deleteTask(title) {
    
    let tasks = JSON.parse(localStorage.getItem('tasks'));
    for (let i = 0; i < tasks.length; i++) {
        if (tasks[i].title == title) {
            tasks.splice(i, 1);
        }
    }

    localStorage.setItem('tasks', JSON.stringify(tasks));
    getTasks();
}


function getTasks() { 
  
    //Tasks var
    let tasks = JSON.parse(localStorage.getItem('tasks'));
    let tasksView = document.getElementById('tasks');
    tasksView.innerHTML = '';
    //Add Tasks
    for (let i = 0; i <tasks.length; i++) {
        let sop = tasks[i].selected;
        let title = tasks[i].title;
        let description = tasks[i].description;
        //Cuadro de Notas
        tasksView.innerHTML += `<div class="card mb-3">
        <div class="card-body">
          <p class="font-weight-bold"><big>${title} - <span class="badge badge-primary">${sop}</span></p><p></big>${description}
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

