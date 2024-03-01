const jurassicParck = [["sorpione", "mosca"], "batterio", "tartaruga", [[[["dinosauro"]]]]]
// console.log(jurassicParck.flat(4))

const entries = ["marco", "simona",,,,,,"claudia"]

// console.log(entries.flat())

const jurassicParckChaos = jurassicParck.flatMap(creature => creature+ " 🦕")


console.log(jurassicParckChaos.flat(4))


