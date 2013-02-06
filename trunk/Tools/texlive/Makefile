
# You should change this according to your setup:
#   - FTLROOT:  Base directory where all the magic happens.  It should contains
#               this Makefile (link it from Tools/texlive/Makefile in the trunk
#               checkout).
#   - COREDIR:  Directory of texlive-core.
#   - DISTDIR:  Where to download distfiles (don't use your regular distfiles
#               directory: the mirroring process would delete your other
#               tarballs).

FTLROOT?=	${HOME}/freebsd-texlive
COREDIR?=	${FTLROOT}/trunk/print/texlive-core
DISTDIR?=	${FTLROOT}/distfiles

# Don't forget to build it.
TLPORT?=	${FTLROOT}/trunk/Tools/tlport/bin/Debug/tlport.exe

# -------------------------------------------------------------------------

# Changing this should not been necessary:
FTLMIRROR?=	rsync://distrib-coffee.ipsl.jussieu.fr/pub/mirrors/ctan/systems/texlive/tlnet/archive/

# -------------------------------------------------------------------------

# Changing this with no good reason to do so will break this Makefile:
FETCHDIR?=	${DISTDIR}/mirror
PUBLICDIR?=	${DISTDIR}/TeXLive
PORTSDIR?=	/usr/ports
RELENGDIR?=	${FTLROOT}/branches/releng
SVNROOT?=	https://freebsd-texlive.googlecode.com/svn

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
	@echo "  - mrproper    -- Remove generated ports (breaks VCS information);"
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

mrproper:
.ifdef V
	@echo "===>  Cleanning generated ports..."
.endif
	@rm -rf ${RELENGDIR}/print

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

link:
.ifdef V
	@echo "===>  Linking print/texlive-core into the releng branch..."
.endif
	@mkdir -p ${RELENGDIR}/print
	@ln -sf ${COREDIR} ${RELENGDIR}/print

build:
.ifdef V
	@echo "===>  Generating all ports..."
.endif
	@env DISTDIR="${DISTDIR}" DISABLE_VULNERABILITIES="yes" DISABLE_LICENSES="yes" mono --debug ${TLPORT} ${TLPORT_FLAGS} ${.CURDIR}/tlpkg/tlpobj ${RELENGDIR} ${FETCHDIR}

rmlink:
.ifdef V
	@echo "===>  Unlinking print/texlive-core from the releng branch..."
.endif
	@rm -f ${RELENGDIR}/print/texlive-core

copy:
.ifdef V
	@echo "===>  Copying ports to ${PORTSDIR}..."
.endif
	@sudo cp -R ${RELENGDIR}/print/ ${PORTSDIR}/print

resum:
.ifdef V
	@echo "===>  Updating distfiles checksums..."
.endif
	@(cd ${RELENGDIR} && env DISTDIR="${DISTDIR}" Tools/resum print/texlive-*)

commit:
.ifdef V
	@echo "===>  Committing..."
.endif
	@svn commit --non-interactive --trust-server-cert -m "(releng) Sync TeXLive packages with upstream." "${RELENGDIR}"
	@(cd "${RELENGDIR}" && svn up --non-interactive --trust-server-cert) > /dev/null
