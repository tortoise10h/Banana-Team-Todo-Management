const deleteCommentAction = async (e) => {
    const commentId = e.target.value;
    const currentUrl = window.location.pathname;

    const result = await sendAjaxRequest(
        `/Comment/DeleteComment/${commentId}`,
        'POST'
    );

    if (result && !result.isSuccess) {
        addContentToGlobalErrorModal(result.data);
        showGlobalErrorModal();
    } else {
        window.location.href = currentUrl;
    }
}

const deleteCommentBtns = document.querySelectorAll(".delete-comment-btn");
for (let i = 0; i < deleteCommentBtns.length; i++) {
    deleteCommentBtns[i].addEventListener("click", deleteCommentAction);
}
