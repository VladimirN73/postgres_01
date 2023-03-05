
FROM node:16-alpine AS development
EXPOSE 3000

WORKDIR /app
COPY . .


# ==== BUILD =====
# Install dependencies (npm ci makes sure the exact versions in the lockfile gets installed)
RUN npm ci 
RUN npm run build

# ==== RUN =======
# Set the env to "production"
ENV NODE_ENV production

# Start the app
CMD [ "npx", "serve", "build" ]