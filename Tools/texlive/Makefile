
# You should change this according to your setup:
#   - FTLROOT:  Base directory where all the magic happens.  It should contains
#               this Makefile (link it from Tools/texlive/Makefile in the trunk
#               checkout).
#   - DISTDIR:  Where to download distfiles (don't use your regular distfiles
#               directory: the mirroring process would delete your other
#               tarballs).

FTLROOT?=	${HOME}/freebsd-texlive
DISTDIR?=	${FTLROOT}/distfiles

# Don't forget to build it.
TLPORT?=	${MASTERDIR}/Tools/tlport/bin/Debug/tlport.exe

# -------------------------------------------------------------------------

# Changing this should not been necessary:
FTLMIRROR?=	rsync://distrib-coffee.ipsl.jussieu.fr/pub/mirrors/ctan/systems/texlive/tlnet/archive/

# -------------------------------------------------------------------------

# Changing this with no good reason to do so will break this Makefile:
FETCHDIR?=	${DISTDIR}/mirror
PUBLICDIR?=	${DISTDIR}/TeXLive
PORTSDIR?=	/usr/ports

MASTERDIR?=	${FTLROOT}/master
GITREPO?=	${FTLROOT}/releng
GITREMOTEURL?=	git@github.com:smortex/freebsd-texlive.git

# -------------------------------------------------------------------------

.ifdef V
.if ${V} == 2
TLPORT_FLAGS=	-vv
RSYNC_VERBOSE=	--progress
.else
TLPORT_FLAGS=	-v
RSYNC_VERBOSE=	-v
.endif
.endif

# -------------------------------------------------------------------------

help:
	@echo "For doing Romain's work, launch:"
	@echo "   ${MAKE} update"
	@echo
	@echo "Other targets (targets with a * are executed as part of update"
	@echo "  - clean*      -- Remove extracted metadata;"
	@echo "  - fetch*      -- Mirror TeXLive distfiles locally;"
	@echo "  - extract*    -- Extracts TeXLive package infromations;"
	@echo "  - versionify* -- Add version information to distfiles;"
	@echo "  - link*       -- Create the texlive-core link in the releng branch;"
	@echo "  - build*      -- Create or update ports in the releng branch;"
	@echo "  - rmlink*     -- Remove the texlive-core link from the releng branch;"
	@echo "  - copy        -- Copy ports to the system's ports tree;"
	@echo "  - resum       -- Update ports the old buggy way (but fast);"
	@echo "  - commit*     -- Push branch modifications."

update:
	@${MAKE} clean fetch extract versionify link build rmlink commit

# -------------------------------------------------------------------------

clean:
.ifdef V
	@echo "===>  Cleanning extracted sources..."
.endif
	@rm -rf tlpkg

fetch:
.ifdef V
	@echo "===>  Updating source tarballs..."
.endif
	@mkdir -p ${FETCHDIR}
	@cd ${FETCHDIR} && rsync ${RSYNC_VERBOSE} -a --no-motd --delete ${FTLMIRROR} .

versionify:
.ifdef V
	@echo "===>  Adding version information to source tarballs..."
.endif
	@mkdir -p ${PUBLICDIR}
	@find ${FETCHDIR} -type f -name '*.tar.xz' | while read file; do \
	    version=`stat -f '%Sm' -t '%Y%m%d' $${file}`; \
	    cp -p "$${file}" "$$(echo -n "$${file}" | sed -Ee "s|${FETCHDIR}|${PUBLICDIR}|" -e "s|^(.*)(\\.tar\\.xz)$$|\1-$${version}\2|")"; \
	done

extract:
.ifdef V
	@echo "===>  Extracting source tarballs..."
.endif
	@for i in ${FETCHDIR}/*.tar.xz; do nice -n 15 tar xf $$i tlpkg/tlpobj/ || ( echo $$i && false ); done

${MASTERDIR}:
	mkdir -p ${MASTERDIR}
	git clone ${GITREMOTEURL} --branch master --single-branch ${MASTERDIR}

link: ${MASTERDIR}
.ifdef V
	@echo "===>  Linking print/texlive-core into the releng branch..."
.endif
	@mkdir -p ${GITREPO}/print
	@ln -sf ${MASTERDIR}/print/texlive-core ${GITREPO}/print

${TLPORT}: ${MASTERDIR}
	cd ${MASTERDIR}/Tools/tlport && xbuild

build: ${TLPORT}
.ifdef V
	@echo "===>  Generating all ports..."
.endif
	@env DISTDIR="${DISTDIR}" DISABLE_VULNERABILITIES="yes" DISABLE_LICENSES="yes" OPTIONS_SET="SRCS" BATCH="yes" mono --debug ${TLPORT} ${TLPORT_FLAGS} ${.CURDIR}/tlpkg/tlpobj ${GITREPO} ${FETCHDIR}

rmlink:
.ifdef V
	@echo "===>  Unlinking print/texlive-core from the releng branch..."
.endif
	@rm -f ${GITREPO}/print/texlive-core

copy:
.ifdef V
	@echo "===>  Copying ports to ${PORTSDIR}..."
.endif
	@sudo cp -R ${GITREPO}/print/ ${PORTSDIR}/print

resum:
.ifdef V
	@echo "===>  Updating distfiles checksums..."
.endif
	@(cd ${GITREPO} && env DISTDIR="${DISTDIR}" Tools/resum print/texlive-*)

commit:
.ifdef V
	@echo "===>  Committing..."
.endif
	@(cd "${GITREPO}" && git commit -m "(releng) Sync TeXLive packages with upstream." && git push)
