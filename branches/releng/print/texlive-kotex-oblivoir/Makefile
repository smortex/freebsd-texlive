# $FreeBSD$

PORTNAME=	kotex-oblivoir
PORTVERSION=	20140627
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	A LaTeX document class for typesetting Korean documents.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/memoir/memoir.cls:${PORTSDIR}/print/texlive-memoir \
		${LOCALBASE}/share/texmf-dist/tex/latex/kotex-utf/contrib/dhucs-cmap.sty:${PORTSDIR}/print/texlive-kotex-utf

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
