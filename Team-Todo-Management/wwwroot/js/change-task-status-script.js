// Change task status 
const changeTaskStatusAction = async (e) => {
  const { id, value: newStatus } = e.currentTarget;
  alert(
    "Task ID: "+id+"\n"+
    "New Status Value: "+newStatus
  )
}

const changeTaskStatusSelectBoxs = document.querySelectorAll('.change-task-status-box');
for (let i = 0; i < changeTaskStatusSelectBoxs.length; i++) {
  changeTaskStatusSelectBoxs[i].addEventListener('change', changeTaskStatusAction);
}