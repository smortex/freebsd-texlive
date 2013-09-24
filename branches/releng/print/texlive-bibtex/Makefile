# $FreeBSD$

PORTNAME=	bibtex
PORTVERSION=	20130409
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Process bibliographies for LaTeX, etc.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
