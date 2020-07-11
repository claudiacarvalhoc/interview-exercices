function findSignatureCounts(arr) {
    const result = Array(arr.length).fill(1);

    for (let studentIndex = 0; studentIndex < arr.length; studentIndex++) {

        let currentStudentIndex = studentIndex;
        // Get the next student index
        const nextStudent = arr[currentStudentIndex];
        // Get the student that is exactly on here side
        const student = studentIndex + 1;
        while (nextStudent !== student) {
            // increment the number of signatures for studentIndex
            result[studentIndex]++;
            // We need to set the currentStudentIndex to the next student that
            // will receive the yearbook
            // Note, the nextStudent reference the student but not the index
            // Therefore, we need to decrement 1 in order to jump to the correct index
            currentStudentIndex = nextStudent - 1;
        }
    }

    return result;
}