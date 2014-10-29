# $FreeBSD$

PORTNAME=	bibtex
PORTVERSION=	20140429
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Process bibliographies for LaTeX, etc.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
