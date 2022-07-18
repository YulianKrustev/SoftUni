function dayOfMount(month, year) {
    const getDays = (year, month) => {
        return new Date(year, month, 0).getDate();
    };

    console.log(getDays(year, month))
}
dayOfMount(1, 2022)