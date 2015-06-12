# $FreeBSD$

PORTNAME=	hyphen-ukrainian
PORTVERSION=	20150412
PORTEPOCH=	1
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Ukrainian hyphenation patterns.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/generic/config/language.dat:${PORTSDIR}/print/texlive-hyphen-base \
		${LOCALBASE}/share/texmf-dist/tex/generic/hyph-utf8/conversions/conv-utf8-ec.tex:${PORTSDIR}/print/texlive-hyph-utf8 \
		${LOCALBASE}/share/texmf-dist/tex/generic/ukrhyph/ukrhyph.tex:${PORTSDIR}/print/texlive-ukrhyph

OPTIONS_EXCLUDE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
