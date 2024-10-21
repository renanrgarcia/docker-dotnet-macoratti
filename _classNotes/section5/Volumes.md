# Volumes

- `docker container run -v <host_folder>:<conatiner_folder> image`. Ex:
  - `docker container run -it --name alp1 -v $(pwd)/test:/usr/share alpine`
