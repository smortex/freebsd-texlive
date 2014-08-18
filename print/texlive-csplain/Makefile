# $FreeBSD$

PORTNAME=	csplain
PORTVERSION=	20140817
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Plain TeX multilanguage support

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/share/texmf-dist/tex/plain/base/plain.tex:${PORTSDIR}/print/texlive-plain \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
