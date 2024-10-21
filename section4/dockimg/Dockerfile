# Base image
FROM debian:10
# Metadata
LABEL version="1.0" name="Debian/nginx"

# Update package list, install nginx and clean the apt cache
RUN apt-get update && apt-get install -y nginx && apt-get clean

# Expose port 80
EXPOSE 80

# Path to executable file
ENTRYPOINT [ "/usr/sbin/nginx" ]

# Command to execute when starting the container
CMD [ "-g", "daemon off;" ]