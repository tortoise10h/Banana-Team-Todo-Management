/** GLOBAL ERROR MODAL */
const showGlobalErrorModal = () => {
    $('#globalErrorModal').modal('show');
}

const addContentToGlobalErrorModal = (data) => {
    document.getElementById('globalErrorContent').innerHTML = data;
}

const hideModalAndShowErrorModal = (modalId) => {
    $(`#${modalId}`).modal('hide');
    $(`#${modalId}`).on('hidden.bs.modal', () => {
        $('#globalErrorModal').modal('show');
    });
}

const hideModalAndShowErrorModalWithContent = (modalId, content) => {
    addContentToGlobalErrorModal(content);
    hideModalAndShowErrorModal(modalId);
}


/** REQUEST */
const sendAjaxRequest = (url, method, data) => {
    return $.ajax({
        url: `${url}`,
        type: `${method}`,
        dataType: 'json',
        data: JSON.stringify(data),
        contentType: 'application/json',
        error: function (err) {
            alert(err.status + " : " + err.statusText);
        }
    });
}

