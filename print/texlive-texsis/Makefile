# $FreeBSD$

PORTNAME=	texsis
PORTVERSION=	20110531
PORTREVISION=	1
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Plain TeX macros for Physicists.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/share/texmf-dist/tex/plain/base/plain.tex:${PORTSDIR}/print/texlive-plain \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
