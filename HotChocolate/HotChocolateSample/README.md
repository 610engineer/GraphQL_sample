# path
https://localhost:7279/graphql

# Query
## ëSåèåüçı
query{
  persons{
    id
    name
    location
  }
}

## idåüçı
query{
  personById (id:1){
    id
    name
    location
  }
}



# Mutation
mutation{
  addPerson (name:"aaa" , location: "Tokyo"){
    id
    name
    location
  }
}
