const addParticipantsToTaskAction = async () => {
    const checkedBoxes = document.querySelectorAll('.user-not-in-todo-checkbox:checked');
    const selectedUserIds = [];
    for (let i = 0; i < checkedBoxes.length; i++) {
        selectedUserIds.push(checkedBoxes[i].value);
    }
    const todoId = document.getElementById('todoIdHidden').value;
    console.log(`TodoId: ${todoId}`);

    if (selectedUserIds.length == 0) {
        hideModalAndShowErrorModalWithContent(
            'addNewParticipantModal',
            'Please choose at least one person to add to this task');
        return;
    }

    const result = await sendAjaxRequest(
        `/Todo/AddTodoParticipants/${todoId}`,
        'POST',
        {
            selectedUserIds
        }
    );

    if (result && !result.isSuccess) {
        hideModalAndShowErrorModalWithContent(
            'addNewParticipantModal',
            result.data);
    } else {
        window.location.href = `/Todo/Edit/${todoId}`;
    }

}

const removeAParticipantAction = (e) => {
    alert(e.currentTarget.value);
}

const addNewParticipantsBtn = document.getElementById('addNewParticipantsBtn');
addNewParticipantsBtn.addEventListener('click', addParticipantsToTaskAction);

const removeAParticipantBtns = document.querySelectorAll('.remove-a-participant-btn');
for (let i = 0; i < removeAParticipantBtns.length; i++) {
    removeAParticipantBtns[i].addEventListener('click', removeAParticipantAction);
}

