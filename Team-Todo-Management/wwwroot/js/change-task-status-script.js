// Change task status 
const changeTaskStatusAction = async (e) => {
	const { id, value: newStatus } = e.currentTarget;
	const currentUrl = window.location.pathname;
	// alert(
	// 	"Task ID: " + id + "\n" +
	// 	"New Status Value: " + newStatus
	// )

	const result = await sendAjaxRequest(
		`/Todo/ChangeStatusOfTodo/${id}`,
		'POST',
		{
			status: parseInt(newStatus)
		}
	);

	if (result && !result.isSuccess) {
		addContentToGlobalErrorModal(result.data);
		showGlobalErrorModal();
	} else {
		window.location.href = currentUrl;
	}
}

const changeTaskStatusSelectBoxs = document.querySelectorAll('.change-task-status-box');
for (let i = 0; i < changeTaskStatusSelectBoxs.length; i++) {
	changeTaskStatusSelectBoxs[i].addEventListener('change', changeTaskStatusAction);
}