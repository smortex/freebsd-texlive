# $FreeBSD$

PORTNAME=	metapost
PORTVERSION=	20140315
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	A development of Metafont for creating graphics.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
