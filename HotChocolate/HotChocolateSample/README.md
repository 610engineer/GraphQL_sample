# Query
## �S������
query{
  persons{
    id
    name
    location
  }
}

## id����
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
