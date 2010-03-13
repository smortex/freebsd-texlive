# New ports collection makefile for:	texlive-bibtex
# Date created:		13/03/2010 04:19:26
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bibtex
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Process bibliographies for LaTeX, etc.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
